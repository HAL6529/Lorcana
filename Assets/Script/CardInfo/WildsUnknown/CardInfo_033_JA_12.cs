using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_12 : CardInfo
{
    public CardInfo_033_JA_12()
    {
        this.cardNo = "033_JA_12";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "安全ロープ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
