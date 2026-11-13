using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_07 : CardInfo
{
    public CardInfo_172_JA_07()
    {
        this.cardNo = "172_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "レディ・クラック";
        this.cardName2 = "たちはだかるめんどり";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
