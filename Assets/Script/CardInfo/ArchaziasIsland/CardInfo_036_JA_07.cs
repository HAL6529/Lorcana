using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_036_JA_07 : CardInfo
{
    public CardInfo_036_JA_07()
    {
        this.cardNo = "036_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉJÉãÉzÅ[Éì";
        this.cardName2 = "óêÌÇÃñ“é“";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
