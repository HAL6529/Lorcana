using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_02 : CardInfo
{
    public CardInfo_112_JA_02()
    {
        this.cardNo = "112_JA_02";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ルミエール";
        this.cardName2 = "カッとなりやすい燭台";
        this.power = 7;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
