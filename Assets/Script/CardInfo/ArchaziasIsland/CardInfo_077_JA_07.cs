using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_07 : CardInfo
{
    public CardInfo_077_JA_07()
    {
        this.cardNo = "077_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "カシェキム";
        this.cardName2 = "いにしえの王";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JocelynSepulveda;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
