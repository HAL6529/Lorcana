using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_216_JA_04 : CardInfo
{
    public CardInfo_216_JA_04()
    {
        this.cardNo = "216_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "Ç©ÇÌÇ¢Ç¢ÉAÉqÉãÇÃéq";
        this.cardName2 = "ÉÑÉoñ⁄Ç»éèÍ";
        this.power = 2;
        this.toughness = 9;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RobertoGatto;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Enchanted;
    }
}
