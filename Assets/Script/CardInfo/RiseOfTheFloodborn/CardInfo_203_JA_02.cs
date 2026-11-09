using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_02 : CardInfo
{
    public CardInfo_203_JA_02()
    {
        this.cardNo = "203_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ネズミのカッチュー";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheTaleOfAMouse;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
