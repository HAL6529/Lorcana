using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_06 : CardInfo
{
    public CardInfo_106_JA_06()
    {
        this.cardNo = "106_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉWÉÉÉXÉ~Éì";
        this.cardName2 = "ÇÕÇÀÇ¡Ç©Ç¶ÇËâ§èó";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
