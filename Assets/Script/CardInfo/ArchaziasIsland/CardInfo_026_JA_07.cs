using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_07 : CardInfo
{
    public CardInfo_026_JA_07()
    {
        this.cardNo = "026_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "カルホーン";
        this.cardName2 = "勇気ある救出者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
