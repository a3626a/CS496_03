using UnityEngine;
using System.Collections;

public class BulletTimeBomb : Bullet {

    private int left_tick;
    private int src_xpos, src_ypos;
    private int des_xpos, des_ypos;
	bool from_user;

	BulletTimeBomb(int left_tick, int src_xpos, int src_ypos, int des_xpos, int des_ypos, bool from_user)
    {
        this.left_tick = left_tick;
        this.src_xpos = src_xpos;
        this.src_ypos = src_ypos;
        this.des_xpos = des_xpos;
        this.des_ypos = des_ypos;
		this.from_user = from_user;
    }

    bool isInExplosionRange(int xpos, int ypos)
    {
        if (xpos == des_ypos && ypos == des_ypos)
            return true;
        return false;
    }

    override
    protected void explode()
    {
		DamagableLatticeBehaviour[] players = (DamagableLatticeBehaviour[])FindObjectsOfType(typeof(DamagableLatticeBehaviour));
		foreach(DamagableLatticeBehaviour iDamagable in players)
        {
			//	if iDamagable is target ( use from_user )
			if (isInExplosionRange(iDamagable.getXPos(), iDamagable.getYPos()))
            {
				iDamagable.getDamage(1);
            }
        }

    }

	override
	void TickUpdate()
	{
		super.TickUpdate ();
		left_tick--;
	}

    override
    protected bool shouldExplode()
    {
		return (left_tick == 0);
    }

}
