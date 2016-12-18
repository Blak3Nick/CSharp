namespace CardGameBlake
{
    class MapLocation
    {
        public int xLocation;
        public int yLocation;
        public bool isOnMap = true;
        public MapLocation(int x, int y)
        {
            this.xLocation = x;
            this.yLocation = y;
        }
        public bool checkMapLocation(int x, int y)
        {
            if (x>=0 && x<=8 && y>= 0 && y <= 6)
            {
                isOnMap = true;
            }
            else
            {
                isOnMap = false;
            }
            return isOnMap;
        }
    }
}