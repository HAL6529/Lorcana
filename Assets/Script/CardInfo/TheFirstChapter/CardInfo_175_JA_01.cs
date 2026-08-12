using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_01 : CardInfo
{
    public CardInfo_175_JA_01()
    {
        this.cardNo = "175_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "フック船長";
        this.cardName2 = "あくどいことを考え";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Elliot Bocxtaele";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
