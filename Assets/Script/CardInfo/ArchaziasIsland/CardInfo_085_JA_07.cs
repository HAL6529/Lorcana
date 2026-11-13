using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_07 : CardInfo
{
    public CardInfo_085_JA_07()
    {
        this.cardNo = "085_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒhƒŠƒ[ƒ‰";
        this.cardName2 = "‚í‚ª‚Ü‚Ü‚È‹`Žo";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
