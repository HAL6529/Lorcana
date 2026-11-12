using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_07 : CardInfo
{
    public CardInfo_105_JA_07()
    {
        this.cardNo = "105_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ギズモダック";
        this.cardName2 = "スーツ装着";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
