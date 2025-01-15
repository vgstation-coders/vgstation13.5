using Content.Shared.Damage;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Climbing.Components;

/// <summary>
///     Adds functionality for a climbable entity to damage and stun entities who attempt to
///     climb it (DragDrop or Climb interactions) under various circumstances.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class BonkableComponent : Component
{
    /// <summary>
    ///     Whether every time you try to climb this thing, you just hit your head instead.
    /// </summary>
    [DataField("riggedForBonk")]
    public bool RiggedForBonk = false;

    /// <summary>
    ///     How long to stun players on bonk, in seconds.
    /// </summary>
    [DataField]
    public TimeSpan BonkTime = TimeSpan.FromSeconds(2);

    /// <summary>
    ///     How much damage to apply on bonk.
    /// </summary>
    [DataField]
    public DamageSpecifier? BonkDamage;

    /// <summary>
    ///     Sound to be played when a bonk happens.
    /// </summary>
    [DataField("bonkSound")]
    public SoundSpecifier? BonkSound = null;
}
