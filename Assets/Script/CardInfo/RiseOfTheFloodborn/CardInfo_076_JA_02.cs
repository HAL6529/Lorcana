using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_02 : CardInfo
{
    public CardInfo_076_JA_02()
    {
        this.cardNo = "076_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "ヒミツのエージェント";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
