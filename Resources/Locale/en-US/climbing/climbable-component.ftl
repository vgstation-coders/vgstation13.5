
### UI

# Verb name for climbing
comp-climbable-verb-climb = Vault

### Interaction Messages

# Shown to you when your character climbs on $climbable
comp-climbable-user-climbs = You jump onto { THE($climbable) }!

# Shown to others when $user climbs on $climbable
comp-climbable-user-climbs-other  = { CAPITALIZE(THE($user)) } jumps onto { THE($climbable) }!

# Shown to you when your character forces someone to climb on $climbable
comp-climbable-user-climbs-force = You force { THE($moved-user) } onto { THE($climbable) }!

# Shown to others when someone forces other $moved-user to climb on $climbable
comp-climbable-user-climbs-force-other = { CAPITALIZE(THE($user)) } forces { THE($moved-user) } onto { THE($climbable) }!

# Shown to you when your character is far away from climbable
comp-climbable-cant-reach = You can't reach there!

# Shown to you when your character can't interact with climbable for some reason
comp-climbable-cant-interact = You can't do that!

# Shown to you when your character isn't able to climb by their own actions
comp-climbable-cant-climb = You are incapable of climbing!

# Shown to you when your character tries to force someone else who can't climb onto a climbable
comp-climbable-target-cant-climb = { CAPITALIZE(THE($moved-user)) } can't go there!

# Shown when you try to climb something but it's rigged to bonk you
comp-climbable-rigged-for-bonk = You bang your head on { THE($climbable) }.

# Shown to others when you try to climb something but it's rigged to bonk you
comp-climbable-rigged-for-bonk-other = { CAPITALIZE(THE($user)) } bangs { POSS-ADJ($user) } head on { THE($climbable) }.
