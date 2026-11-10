using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_02 : CardInfo
{
    public CardInfo_168_JA_02()
    {
        this.cardNo = "168_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉÇÅ[ÉäÉXÇÃçHñ[";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AntoniaFlechsig;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
