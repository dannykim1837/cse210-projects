public class Scripture {

    public string GetScripture() {
    List<string> scriptures = new List<string>
            {
                "For aGod so bloved the cworld, that he dgave his eonly begotten fSon, that whosoever gbelieveth in him should not perish, but have heverlasting ilife.",
                "For God asent not his Son into the world to bcondemn the world; but that the world through him might be csaved.",
                "He that believeth on him is not condemned: but he that abelieveth not is condemned already, because he hath not believed in the bname of the only begotten cSon of God.",
                "And this is the condemnation, that alight is come into the world, and men loved bdarkness rather than light, because their cdeeds were evil.",
                "For every one that doeth aevil bhateth the light, neither cometh to the light, lest his deeds should be reproved.",
                "But he that adoeth btruth cometh to the clight, that his deeds may be made manifest, that they are wrought in God.",
                "After these things came Jesus and his disciples into the land of Judæa; and there he tarried with them, and abaptized."
            };
            Random random = new Random();
            int index = random.Next(scriptures.Count);
            
            return scriptures[index];
    }
}