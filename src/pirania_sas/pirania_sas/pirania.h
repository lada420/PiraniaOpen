#pragma once
class pirania
{
private:
    int m_xcoord = 0;
    int m_ycoord = 0;
    double m_distance = 0;
    double m_signal_level = 0;
public:
    pirania();
    pirania(int x, int y);
    pirania(int x, int y, double distance, double signal_level);

    void setX(int new_x);
    void setY(int new_y);
    void setDistance(int x, int y);
    void setSignalLevel(double new_sig_lvl);

    int getX();
    int getY();
    double getDistance();
    double getSignalLevel();

};

