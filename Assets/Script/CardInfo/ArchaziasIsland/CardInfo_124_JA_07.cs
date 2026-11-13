using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_07 : CardInfo
{
    public CardInfo_124_JA_07()
    {
        this.cardNo = "124_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デナヒ";
        this.cardName2 = "短気なハンター";
        this.power = 3;
        this.toughness = 2;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Reckless, EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
