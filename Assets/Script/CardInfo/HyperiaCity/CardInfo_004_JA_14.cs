using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_14 : CardInfo
{
    public CardInfo_004_JA_14()
    {
        this.cardNo = "004_JA_14";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ガゼル";
        this.cardName2 = "ポップの歌姫";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AntoneCouttolenc;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
