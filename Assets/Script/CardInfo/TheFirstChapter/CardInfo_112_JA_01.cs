using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_01 : CardInfo
{
    public CardInfo_112_JA_01()
    {
        this.cardNo = "112_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉãÅEÉtÉD";
        this.cardName2 = "Ç†Ç®ÇËâÆ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Gaku Kumatori";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
