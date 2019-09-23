using System;
using System.Collections.Generic;

namespace the_aztec_game
{
  class Configs
  {
    public const int PRINT_DELAY = 20; // ms 
    // public const int PRINT_DELAY = 1; // ms 
    public const int DAMAGE_PRECISION = 2;
    public const int DRUM_DELAY = 1500; //  ms
    // public const int DRUM_DELAY = 1;
    public const int RING_DELAY = 4000; // ms
    // public const int RING_DELAY = 1;
    public const int JP_CONVO_DELAY = 3000;
    // public const int JP_CONVO_DELAY = 1;
    public const int DAN_CONVO_DELAY = 2000;
    // public const int DAN_CONVO_DELAY = 1;

    public const string INSTRUCTIONS = @"
            
Instructions:
  <n, s, e and w> - move around the temple (north, south, east and west respectively)
  <i>             - check your inventory
  <st>            - check your current status
  <d>             - obtain description of the room you're in
  <l>             - look around the room
  <help>          - instructions

";

    public static Dictionary<int, int[]> ENEMY_DIFFICULTY = new Dictionary<int, int[]>()
    {
        {1, new int[]{2, 3}},
        {2, new int[]{4, 6, 10}},
        {3, new int[]{5, 8, 9}},
        {4, new int[]{7}},
        {5, new int[]{1}},
        {6, new int[]{0}}
    };

  }
}