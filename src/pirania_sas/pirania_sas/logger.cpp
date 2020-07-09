#include "logger.h"
#include <fstream>

void logger::log_info(std::string& msg)
{
    std::cout << "[INFO] " << msg << std::endl;
}

void logger::log_warn(std::string& msg)
{
    std::cout << "[WARN] " << msg << std::endl;
}

void logger::log_error(std::string& msg)
{
    std::cout << "[ERROR] " << msg << std::endl;
}

#ifdef FILELOG
logger::logger(std::string& path_to_log)
{
    logger::m_path_to_log = path_to_log;
}

void logger::log_info(std::string& msg)
{
    std::ofstream log;
    log.open(logger::m_path_to_log, std::ios::out | std::ios::app);
    log << "[INFO] " << msg << std::endl;
    log.close();
}

void logger::log_warn(std::string& msg)
{
    std::ofstream log;
    log.open(logger::m_path_to_log, std::ios::out | std::ios::app);
    log << "[WARN] " << msg << std::endl;
    log.close();
}

void logger::log_error(std::string& msg)
{
    std::ofstream log;
    log.open(logger::m_path_to_log, std::ios::out | std::ios::app);
    log << "[ERROR] " << msg << std::endl;
    log.close();
}
#endif