using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_07 : CardInfo
{
    public CardInfo_064_JA_07()
    {
        this.cardNo = "064_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "虚栄の魔女";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
