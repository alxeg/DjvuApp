#pragma once

#include <string>

#define HAVE_EXCEPTIONS
#define HAVE_STDINCLUDES
#define MINILISPAPI
#define DEBUGLVL 0

char* getenv(char*);

std::wstring GetWorkingDirectory();