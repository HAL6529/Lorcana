using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_07 : CardInfo
{
    public CardInfo_020_JA_07()
    {
        this.cardNo = "020_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "キャンディ大王";
        this.cardName2 = "王様レーサー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
