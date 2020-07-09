#pragma once
#include <array>
#define LENGTH 100 //change theese values when mapgen is done
#define HIGHT 100

using quadrant = std::array<std::array<int, LENGTH>, HIGHT>;

class land_layer
{
private:
    int m_num_of_quadrants = 1;
    quadrant *m_landscape;

public:
    land_layer(int num_of_qadrants);
    ~land_layer();
};

