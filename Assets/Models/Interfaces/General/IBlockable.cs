using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public interface IBlockable 
{
     int BlockDamage { get; set; }
     int BlockFire { get; set; }
     int BlockLightning { get; set; }
     int BlockMagic { get; set; }
}
