#include "utility/posix/PosixDll.h"

#include <array>
#include <new>
#include <string>
#include <type_traits>

#include <dlfcn.h>

namespace zen
{
    namespace
    {
        static unsigned int g_niftyCounter = 0;
        static std::aligned_storage_t<sizeof(PosixDll), alignof(PosixDll)> g_singletonBuffer;
        PosixDll& g_singleton = reinterpret_cast<PosixDll&>(g_singletonBuffer);
    }

    PlatformDllInitializer::PlatformDllInitializer()
    {
        if (g_niftyCounter++ == 0)
            new (&g_singleton) PosixDll();
    }

    PlatformDllInitializer::~PlatformDllInitializer()
    {
        if (--g_niftyCounter == 0)
            (&g_singleton)->~PosixDll();
    }

    IPlatformDll& IPlatformDll::get() noexcept
    {
        return g_singleton;
    }

    void* PosixDll::load(std::string_view filename)
    {
        // std::filesystem support is lagging behind on MacOS, so no
        // path concatenation.
        // We can assume a POSIX filesystem here.
        const auto filePath = std::string("./") + std::string(filename);
        return ::dlopen(filePath.c_str(), RTLD_LAZY);
    }

    void PosixDll::unload(void* handle)
    {
        if (handle)
            ::dlclose(handle);
    }

    void* PosixDll::procedure(void* handle, std::string_view procName)
    {
        if (handle == nullptr)
            return nullptr;

        return ::dlsym(handle, procName.data());
    }
}
