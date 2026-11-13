using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_07 : CardInfo
{
    public CardInfo_161_JA_07()
    {
        this.cardNo = "161_JA_07";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ÉhÅ[É\Éì";
        this.cardName2 = "éÒÇåXÇ∞ÇÈíTí„";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
