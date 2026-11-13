using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_07 : CardInfo
{
    public CardInfo_171_JA_07()
    {
        this.cardNo = "171_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Ç›Ç»ÇµÇ≤ÇÃÉyÉjÅ[";
        this.cardName2 = "Ç©ÇµÇ±Ç¢è≠èó";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
