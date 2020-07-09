#include "pirania.h"
#include <cmath>
#include <assert.h>

//#define NDEBUG //Uncomment on release

pirania::pirania() = default;
pirania::pirania(int x, int y)
{
    m_xcoord = x;
    m_ycoord = y;
}

pirania::pirania(int x, int y, double distance, double signal_level)
{
    m_xcoord = x;
    m_ycoord = y;
    m_distance = distance;
    m_signal_level = signal_level;
}

int pirania::getX() { return m_xcoord; }
int pirania::getY() { return m_ycoord; }
double pirania::getDistance() { return m_distance; }
double pirania::getSignalLevel() { return m_signal_level; }


void pirania::setX(int new_x) { assert(new_x>= 0); m_xcoord = new_x; }
void pirania::setY(int new_y) { assert(new_y >= 0); m_ycoord = new_y; }
void pirania::setSignalLevel(double new_sig_lvl) { assert(new_sig_lvl >=0); m_signal_level = new_sig_lvl; }
void pirania::setDistance(int x, int y) 
{
 assert(x >= 0 && y >= 0);
 auto new_dist = pow(pow(static_cast<double>(m_xcoord-x), 2.0) + pow(static_cast<double>(m_ycoord-y), 2.0), 0.5);
 m_distance = new_dist;
}