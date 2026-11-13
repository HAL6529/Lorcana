using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_07 : CardInfo
{
    public CardInfo_123_JA_07()
    {
        this.cardNo = "123_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "Ç®íáêlÇ≥ÇÒ";
        this.cardName2 = "ì`ìùç•äàÇÃêÊê∂";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
