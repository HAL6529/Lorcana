using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_07 : CardInfo
{
    public CardInfo_007_JA_07()
    {
        this.cardNo = "007_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ペグ";
        this.cardName2 = "生粋のパフォーマー";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
