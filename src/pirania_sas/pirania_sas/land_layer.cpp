#include "land_layer.h"

land_layer::land_layer(int num_of_quadrants)
{
    m_landscape = new quadrant[num_of_quadrants];
}

land_layer::~land_layer()
{
    delete m_landscape;
}