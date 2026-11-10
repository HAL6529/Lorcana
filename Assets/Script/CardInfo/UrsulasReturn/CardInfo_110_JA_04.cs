using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_04 : CardInfo
{
    public CardInfo_110_JA_04()
    {
        this.cardNo = "110_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉJÅ[Éì";
        this.cardName2 = "à§în";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
