using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_03 : CardInfo
{
    public CardInfo_168_JA_03()
    {
        this.cardNo = "168_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉxÉãÇÃâ∆";
        this.cardName2 = "ÉÇÅ[ÉäÉXÇÃçHñ[";
        this.power = 2;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.AlexShin;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
