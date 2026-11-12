using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_07 : CardInfo
{
    public CardInfo_133_JA_07()
    {
        this.cardNo = "133_JA_07";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "リー・シャン";
        this.cardName2 = "新米隊長";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
