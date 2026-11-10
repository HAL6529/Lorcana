using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_04 : CardInfo
{
    public CardInfo_028_JA_04()
    {
        this.cardNo = "028_JA_04";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ëÂè‰ïvÅAâ∆ë∞Ç™Ç¢ÇÈ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MGiuliaRiva;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether7 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
