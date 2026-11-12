using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_07 : CardInfo
{
    public CardInfo_089_JA_07()
    {
        this.cardNo = "089_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉsÅ[Ég";
        this.cardName2 = "äCëØÇÃà´äø";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SerenaWade;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
