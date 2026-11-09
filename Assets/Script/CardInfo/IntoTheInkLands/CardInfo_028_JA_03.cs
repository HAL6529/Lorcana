using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_03 : CardInfo
{
    public CardInfo_028_JA_03()
    {
        this.cardNo = "028_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "THE BARE NECESSITIES";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MaxineVeeAndDavidNavarroArenas;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
