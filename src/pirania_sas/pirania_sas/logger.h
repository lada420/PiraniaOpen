#pragma once
#include <string>
#include <iostream>

#define FILELOG

class logger
{
private:
#ifdef FILELOG
    std::string m_path_to_log;
#endif


public:
    logger() = default;
    void log_info(std::string& msg);
    void log_warn(std::string& msg);
    void log_error(std::string& msg);

#ifdef FILELOG
    logger(std::string& path_to_log);
    void log_info(std::string& msg);
    void log_warn(std::string& msg);
    void log_error(std::string& msg);
#endif

};

