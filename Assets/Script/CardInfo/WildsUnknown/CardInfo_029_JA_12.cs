using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_12 : CardInfo
{
    public CardInfo_029_JA_12()
    {
        this.cardNo = "029_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ずんずん増してくプレッシャー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
