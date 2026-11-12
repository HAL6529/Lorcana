using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_07 : CardInfo
{
    public CardInfo_059_JA_07()
    {
        this.cardNo = "059_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "イズマ";
        this.cardName2 = "ネコになった婆様";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
