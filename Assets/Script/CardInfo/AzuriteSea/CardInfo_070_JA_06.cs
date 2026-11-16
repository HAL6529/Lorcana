using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_06 : CardInfo
{
    public CardInfo_070_JA_06()
    {
        this.cardNo = "070_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉWÉÉÉXÉ~Éì";
        this.cardName2 = "çÇãMÇ»ÇÈçqäCé“";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SedaCoskun;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
