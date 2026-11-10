using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_04 : CardInfo
{
    public CardInfo_089_JA_04()
    {
        this.cardNo = "089_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "â^ñΩÇÃéOèóê_";
        this.cardName2 = "ñ⁄ã ÇÕÇ–Ç∆Ç¬";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JonDenskAndHayleyEvans;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
