using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_101_JA_07 : CardInfo
{
    public CardInfo_101_JA_07()
    {
        this.cardNo = "101_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "イズマ";
        this.cardName2 = "イライラ陰謀家";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MelMilton;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
