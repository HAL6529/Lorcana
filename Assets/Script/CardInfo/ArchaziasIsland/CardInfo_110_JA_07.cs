using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_07 : CardInfo
{
    public CardInfo_110_JA_07()
    {
        this.cardNo = "110_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉgÉâÉìÉv";
        this.cardName2 = "êÿÇÍé“ÇÃå¢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmandaMacFarlane;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
