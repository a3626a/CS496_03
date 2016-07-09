using System;

public class PlayerController : DamagableLatticeBehaviour
{
	private Type bulletType;

	public PlayerController ()
	{
		
	}

	void setBulletType(Type bulletType)	//	parameter example) typeof(BulletTimeBomb)
	{
		this.bulletType = bulletType;
	}

	void fire()
	{
		Bullet bullet = (Bullet)Activator.CreateInstance (bulletType);
		//	TODO : fire bullet
	}

	public void getDamage(double damage)
	{
		//TODO : game lose routine
	}
}