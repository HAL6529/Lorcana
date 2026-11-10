using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_04 : CardInfo
{
    public CardInfo_083_JA_04()
    {
        this.cardNo = "083_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉyÉKÉTÉX";
        this.cardName2 = "â_ÇÃã£ëñîn";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
