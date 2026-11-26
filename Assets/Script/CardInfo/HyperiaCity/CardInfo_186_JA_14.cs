using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_14 : CardInfo
{
    public CardInfo_186_JA_14()
    {
        this.cardNo = "186_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ベルリオーズ";
        this.cardName2 = "小っちゃないたずらっ子";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
