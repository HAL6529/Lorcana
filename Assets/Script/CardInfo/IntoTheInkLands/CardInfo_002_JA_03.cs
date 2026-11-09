using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_03 : CardInfo
{
    public CardInfo_002_JA_03()
    {
        this.cardNo = "002_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "バーナード";
        this.cardName2 = "新参エージェント";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JacobMcAlister;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
