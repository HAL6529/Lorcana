using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_03 : CardInfo
{
    public CardInfo_020_JA_03()
    {
        this.cardNo = "020_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉnÅ[ÉgÇÃèóâ§";
        this.cardName2 = "Ç”ÇµÇ¨ÇÃçëÇÃèóíÈ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BriannaGarcia;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
