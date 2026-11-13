using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_07 : CardInfo
{
    public CardInfo_106_JA_07()
    {
        this.cardNo = "106_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "フィジット";
        this.cardName2 = "こっそりコウモリ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
