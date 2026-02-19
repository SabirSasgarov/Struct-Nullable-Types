using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Struct_Nullable_Types.Enums;
namespace Struct_Nullable_Types.Models
{
    internal class Weapon
    {
        public int BulletCapacity { get; set; }
        public int CurrentBulletCount { get; set; }
        public TimeSpan SecondsToFireAllBullets { get; set; }
        public WeaponShootType FireMode { get; set; }
        public Weapon(int bulletCapacity, int currentBulletCount, TimeSpan secondsToFireAllBullets, WeaponShootType type)
        {
            BulletCapacity = bulletCapacity;
            CurrentBulletCount = currentBulletCount;
            SecondsToFireAllBullets = secondsToFireAllBullets;
            FireMode = type;
        }
        public void Shoot()
        {
            if (CurrentBulletCount > 0)
            {
                CurrentBulletCount--;
                Console.WriteLine("Shoot!");
            }
            else
            {
                Console.WriteLine("No bullets left!");
            }
        }
        public void Fire()
        {
            if (CurrentBulletCount > 0)
            {
                Console.WriteLine(SecondsToFireAllBullets*CurrentBulletCount/BulletCapacity);
                CurrentBulletCount = 0;
            }
            else
            {
                Console.WriteLine("No bullets left!");
            }
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine($"Bullets you need - {BulletCapacity - CurrentBulletCount}");
        }
        public void Reload()
        {
            CurrentBulletCount = BulletCapacity;
        }
        public void ChangeFireMode()
        {
            if (FireMode == WeaponShootType.SingleShot)
                FireMode = WeaponShootType.Automatic;
            else
                FireMode = WeaponShootType.SingleShot;
        }
        public override string ToString()
        {
            return $"Bullet capacity - {BulletCapacity}, Remaining bullets - {CurrentBulletCount}, Needed time to spend all bullets - {SecondsToFireAllBullets}, Fire mode - {FireMode}.";
        }



    }
}
