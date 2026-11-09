using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_02 : CardInfo
{
    public CardInfo_185_JA_02()
    {
        this.cardNo = "185_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クロンク";
        this.cardName2 = "生き物クラブの部長";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
