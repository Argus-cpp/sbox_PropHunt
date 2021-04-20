using Sandbox;
using System;

partial class PropHuntPlayer : BasePlayer
{
    private int Team { get; set; }

    public PropHuntPlayer()
    {
        
    }

    public override void Respawn()
    {
        ClearAmmo();

        SetModel("models/citizen/citizen.vmdl");

        if (Team == 1)
        {
            GiveAmmo(AmmoType.Crossbow, 4);
        }
        else if (Team == 2)
        {
            StripWeapons();
        }

        base.Respawn();
    }

    public override void SetPropModel(string Model, int Health)
    {
        if (Team == 1)
            return;

        SetModel(Model);
        SetHealth(Health);
    }
}