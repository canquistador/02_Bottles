using System;
namespace _02_Bottles
{
    public class Song
    {
        //create variables of various strings
        string space        = " ";
        string wall_sing    = " bottle of beer on the wall.";
        string wall_plural  = " bottles of beer on the wall.";
        string short_sing   = " bottle of beer.";
        string short_plural = " bottles of beer.";
        string take_down    = " Take one down and pass it around.";
        string end          = " No more bottles of beer on the wall.";

        //CountBottles handles input less than zero, with a simple string.
        //It also handles an input of zero by returning the "end" variable.
        //If theres more than zero, it gets passed on to StartSong.
        public string CountBottles(int bottles)
        {
            if (bottles < 0)
            {
                return "We require additional bottles!";
            }
            else if (bottles == 0)
            {
                return end;
            }
            else 
            {
                return StartSong(bottles);
            }   
        }
        //StartSong only uses the "wall" variable once, and when that is done
        //it calls FinishSong, which uses "wall" variables twice!
        public string StartSong(int bottles)
        {
            if (bottles >= 2)
            {
                return bottles + wall_plural
                    + space + bottles + short_plural + FinishSong(bottles-1);
            }
            else
            {
                return bottles + wall_sing
                    + space + bottles + short_sing + FinishSong(bottles-1);
            }   
        }
        public string FinishSong(int bottles)
        {
                //After the StartSong has finished doing it's thing, we check to see
                //whether plural or singular bottle(s) should be chosen, and iterate
                //recursively (method calling itself)
                if (bottles >= 2)
                {
                    return take_down
                        + space + bottles + wall_plural
                        + space + bottles + wall_plural
                        + space + bottles + short_plural + FinishSong(bottles-1);
                }
                else if (bottles == 1)
                {
                    return take_down
                        + space + bottles + wall_sing
                        + space + bottles + wall_sing
                        + space + bottles + short_sing + FinishSong(bottles-1);
                }
                else
                {
                    return take_down + end;
                }
        }
    }
}