using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_02 : CardInfo
{
    public CardInfo_144_JA_02()
    {
        this.cardNo = "144_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "クルエラ";
        this.cardName2 = "ファッショナブルなドライバー";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
